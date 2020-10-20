
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces

Imports System.Web.Script.Serialization '(Importing System.Web.Script.Serialization) This is used to read and convert JSON strings.
Imports System.ComponentModel '(Importing System.ComponentModel) This is used to sort data on DataGridView.
Imports System.IO '(Importing System.IO) This is used for ImageToBase64 Public Functions and Base64ToImage Public Functions.
Public Class Form1
    Dim IMG_FileNameInput As String 'This variable is used to hold the address and file name of the image that will be displayed in the registration section.
    Dim clearDGVCol As Boolean = True
    Private dtTableGrd As DataTable 'This variable is used to search data on DataGridView.

    '-------------------------------------------Configure FireSharp
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "USfDNM94FUaDhskL0EhQ8n4KgnqC1VSzBbOcPzkl",
        .BasePath = "https://projectcrud01.firebaseio.com/"
        }

    Private client As IFirebaseClient
    '-------------------------------------------

    Public Function ImageToBase64(image As Image) As String
        Using ms As New MemoryStream()
            ' Convert Image to byte[]  
            Dim Format As System.Drawing.Imaging.ImageFormat = Imaging.ImageFormat.Jpeg
            image.Save(ms, Format)
            Dim imageBytes As Byte() = ms.ToArray()

            ' Convert byte[] to Base64 String  
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function


    Public Function Base64ToImage(base64String As String) As Image
        ' Convert Base64 String to byte[]  
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)

        ' Convert byte[] to Image  
        ms.Write(imageBytes, 0, imageBytes.Length)
        Dim image__1 As Image = System.Drawing.Image.FromStream(ms, True)
        Return image__1
    End Function
    '-------------------------------------------
    Sub DisplayRegSave(Stat As Boolean)
        TBName.Enabled = Stat
        TBID.Enabled = Stat
        CBGender.Enabled = Stat
        CBGender.Enabled = Stat
        BtnSave.Enabled = Stat
        BtnClearAll.Enabled = Stat
    End Sub

    Sub DisplayRecLoad(Stat As Boolean)
        TBSearch.Enabled = Stat
        CBSearchBy.Enabled = Stat
        BtnEdit.Enabled = Stat
        BtnDelete.Enabled = Stat
        BtnRefresh.Enabled = Stat
        BtnClearSelection.Enabled = Stat
        DGVUserData.Enabled = Stat
    End Sub
    '-------------------------------------------

    '-------------------------------------------Sub to load data from database and display in DataGridView.
    Sub ShowRecord()
        Try
            Dim dtTable As New DataTable
            dtTable.Columns.Add("Name")
            dtTable.Columns.Add("ID")
            dtTable.Columns.Add("Gender")
            dtTable.Columns.Add("City")
            dtTable.Columns.Add("Image", GetType(Image))

            '-------------------------------------------Conditions for deleting columns. This was executed only once.
            If clearDGVCol = True Then
                DGVUserData.Columns.Clear()
                clearDGVCol = False
            End If
            '-------------------------------------------

            Dim SRRecord = client.Get("PersonDB/") 'To load and hold Database in JSON file format.

            '-------------------------------------------To converts the specified JSON string to an object of type T.
            '-------------------------------------------For more information see here : 
            '-------------------------------------------https://docs.microsoft.com/en-us/dotnet/api/system.web.script.serialization.javascriptserializer.deserialize?view=netframework-4.8
            Dim myJsonTool As New JavaScriptSerializer
            Dim myDeserializedItems = myJsonTool.Deserialize(Of Dictionary(Of String, PersonalData))(SRRecord.Body)
            '-------------------------------------------

            '-------------------------------------------To enter a Database (in JSON file format that has been previously converted into an object form) into a Table.
            For Each dictItem As KeyValuePair(Of String, PersonalData) In myDeserializedItems
                dtTable.Rows.Add(dictItem.Value.Name,
                                 dictItem.Value.ID,
                                 dictItem.Value.Gender,
                                 dictItem.Value.City,
                                 Base64ToImage(dictItem.Value.Image))
            Next
            '-------------------------------------------

            DGVUserData.DataSource = dtTable 'Gets or sets the data source that the DataGridView is displaying data for.
            dtTableGrd = dtTable 'Entering data from dtTable into dtTableGrd, dtTableGrd is used to find data and display it on DataGridView.

            Dim imageColumn = DirectCast(DGVUserData.Columns("Image"), DataGridViewImageColumn)
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
            '-------------------------------------------

            DGVUserData.Sort(DGVUserData.Columns(0), ListSortDirection.Ascending)

            LblTotalUser.Text = "Total Users : " & DGVUserData.RowCount

            Me.Text = "VB Net Firebase RealTime Database"
            LabelRecordView.Text = "Record View"
            DisplayRecLoad(True)

            DGVUserData.ClearSelection()
        Catch ex As Exception
            If ex.Message = "One or more errors occurred." Then
                MessageBox.Show("Cannot connect to firebase, check your network !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ex.Message = "Object reference not set to an instance of an object." Then
                Dim dtTable As New DataTable
                dtTable.Columns.Add("Name")
                dtTable.Columns.Add("ID")
                dtTable.Columns.Add("Gender")
                dtTable.Columns.Add("City")
                dtTable.Columns.Add("Image", GetType(Image))
                DGVUserData.DataSource = dtTable
                MessageBox.Show("Database not found or Database is empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Me.Text = "VB Net Firebase RealTime Database"
            LabelRecordView.Text = "Record View"
            DisplayRecLoad(True)
        End Try
    End Sub
    '-------------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            client = New FireSharp.FirebaseClient(fcon)
            BtnRefresh_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        CBSearchBy.SelectedIndex = 0
    End Sub

    Private Sub BtnCreateID_Click(sender As Object, e As EventArgs) Handles BtnCreateID.Click
        Try
            TBID.Text = "Please wait..."

            Dim r As Random = New Random
            Dim num As Integer
            num = (r.Next(1, 99999))
            Dim IDresults As String = Strings.Right("00000" & num.ToString(), 5)

            Dim Check_ID = client.Get("PersonDB/" + IDresults)

            '-------------------------------------------Conditions to check whether the ID has been used.
            If Check_ID.Body <> "null" Then
                MessageBox.Show("The same ID is found, create another ID by pressing the Create ID button.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                TBID.Text = IDresults
            End If
            '-------------------------------------------
        Catch ex As Exception
            If ex.Message = "One or more errors occurred." Then
                TBID.Clear()
                MessageBox.Show("Cannot connect to firebase, check your network !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                TBID.Clear()
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If BtnSave.Text = "Save" Then 'Conditions for storing data to the database.
            If TBName.Text = Nothing Then
                MessageBox.Show("Name field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If TBID.Text = Nothing Then
                MessageBox.Show("ID field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If CBGender.Text = Nothing Then
                MessageBox.Show("Gender field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If TBCity.Text = Nothing Then
                MessageBox.Show("City field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If IMG_FileNameInput = Nothing Then
                MessageBox.Show("Image file has not been entered." & vbCrLf & "Please enter the image to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                Me.Text = "VB Net Firebase RealTime Database (Saving. Please wait...)"
                LabelRegistration.Text = "Registration (Saving. Please wait...)"
                DisplayRegSave(False)

                Dim ImgData As String = ImageToBase64(PictureBoxUserReg.Image)

                Dim PD As New PersonalData() With
                    {
                    .Name = TBName.Text,
                    .ID = TBID.Text,
                    .Gender = CBGender.Text,
                    .City = TBCity.Text,
                    .Image = ImgData
                    }

                Dim save = client.Set("PersonDB/" + TBID.Text, PD) 'To save data to Firebase Database.

                DisplayRegSave(True)
                LabelRegistration.Text = "Registration"
                Me.Text = "VB Net Firebase RealTime Database"

                MessageBox.Show("Data saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                BtnClearAll_Click(sender, e)
                BtnRefresh_Click(sender, e)
            Catch ex As Exception
                If ex.Message = "One or more errors occurred." Then
                    MessageBox.Show("Cannot connect to firebase, check your network !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                DisplayRegSave(True)
                LabelRegistration.Text = "Registration"
                Me.Text = "VB Net Firebase RealTime Database"
            End Try

        Else 'Conditions for updating data to a database.

            If TBName.Text = Nothing Then
                MessageBox.Show("Name field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If TBCity.Text = Nothing Then
                MessageBox.Show("City field is empty." & vbCrLf & "Please fill in the name field to continue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                Me.Text = "VB Net Firebase RealTime Database (Updating. Please wait...)"
                LabelRegistration.Text = "Registration (Updating. Please wait...)"
                DisplayRegSave(False)

                Dim ImgData As String = ImageToBase64(PictureBoxUserReg.Image)

                Dim PD As New PersonalData() With
                    {
                    .Name = TBName.Text,
                    .ID = TBID.Text,
                    .Gender = CBGender.Text,
                    .City = TBCity.Text,
                    .Image = ImgData
                    }

                Dim update = client.Update("PersonDB/" + TBID.Text, PD) 'To update data to Firebase Database.

                DisplayRegSave(True)
                LabelRegistration.Text = "Registration"
                Me.Text = "VB Net Firebase RealTime Database"

                MessageBox.Show("Data updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                BtnClearAll_Click(sender, e)
                BtnRefresh_Click(sender, e)
            Catch ex As Exception
                If ex.Message = "One or more errors occurred." Then
                    MessageBox.Show("Cannot connect to firebase, check your network !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                DisplayRegSave(True)
                LabelRegistration.Text = "Registration"
                Me.Text = "VB Net Firebase RealTime Database"
            End Try
        End If
    End Sub

    Private Sub PictureBoxUserReg_Click(sender As Object, e As EventArgs)

        OpenFileDialogUserImage.FileName = ""
        OpenFileDialogUserImage.Filter = "JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg"

        If (OpenFileDialogUserImage.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            IMG_FileNameInput = OpenFileDialogUserImage.FileName
            PictureBoxUserReg.ImageLocation = IMG_FileNameInput
        End If
    End Sub

    Private Sub BtnClearAll_Click(sender As Object, e As EventArgs) Handles BtnClearAll.Click
        TBName.Clear()
        TBID.Clear()
        CBGender.Text = Nothing
        TBCity.Clear()
        PictureBoxUserReg.Image = My.Resources.avatar
        IMG_FileNameInput = Nothing
        BtnSave.Text = "Save"
        BtnCreateID.Enabled = True
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Me.Text = "VB Net Firebase RealTime Database (Loading. Please wait...)"
        LabelRecordView.Text = "Record View (Loading. Please wait...)"
        DisplayRecLoad(False)
        ShowRecord()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        '-------------------------------------------The condition to check whether the data to be edited has been selected in DataGridView
        If DGVUserData.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select one row in the table to edit.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        '-------------------------------------------

        '-------------------------------------------Conditions to check whether there is more than one data selected on DataGridView.
        If DGVUserData.SelectedRows.Count > 1 Then
            MessageBox.Show("You select " & DGVUserData.SelectedRows.Count & " rows in the Table." & vbCrLf & "The Edit feature can only edit one row in a table.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        '-------------------------------------------

        If DGVUserData.SelectedRows.Count = 1 Then
            TBName.Text = DGVUserData.SelectedRows(0).Cells("Name").Value
            TBID.Text = DGVUserData.SelectedRows(0).Cells("ID").Value
            CBGender.Text = DGVUserData.SelectedRows(0).Cells("Gender").Value
            TBCity.Text = DGVUserData.SelectedRows(0).Cells("City").Value
            PictureBoxUserReg.Image = DGVUserData.Rows(DGVUserData.SelectedRows(0).Index).Cells("Image").Value
            BtnSave.Text = "Update"
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        '-------------------------------------------Conditions for deleting all data in the database.
        If AllCellsSelected(DGVUserData) = True Then
            Try
                If MsgBox("Are you sure you want to delete all data ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

                Me.Text = "VB Net Firebase RealTime Database (Deleting. Please wait...)"
                LabelRecordView.Text = "Record View (Deleting. Please wait...)"
                DisplayRecLoad(False)

                Dim deleteAll = client.Delete("PersonDB") 'To delete data in the Firebase Database

                MessageBox.Show("Data successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Text = "VB Net Firebase RealTime Database"
                LabelRecordView.Text = "Record View"
                DisplayRecLoad(True)

                BtnRefresh_Click(sender, e)
                Return
            Catch ex As Exception
                If ex.Message = "One or more errors occurred." Then
                    MessageBox.Show("Cannot connect to firebase, check your network !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                Me.Text = "VB Net Firebase RealTime Database"
                LabelRecordView.Text = "Record View"
                DisplayRecLoad(True)
            End Try
        End If
        '-------------------------------------------

        '-------------------------------------------Conditions for deleting one data or several data in the Database.
        Try
            If DGVUserData.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select one row or several rows to be deleted.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If MsgBox("Are you sure you want to delete this data ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

            Me.Text = "VB Net Firebase RealTime Database (Deleting. Please wait...)"
            LabelRecordView.Text = "Record View (Deleting. Please wait...)"
            DisplayRecLoad(False)

            For Each row As DataGridViewRow In DGVUserData.SelectedRows
                If row.Selected = True Then
                    Dim delete = client.Delete("PersonDB/" & row.DataBoundItem(1).ToString)
                End If
            Next

            MessageBox.Show("Data successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Text = "VB Net Firebase RealTime Database"
            LabelRecordView.Text = "Record View"
            DisplayRecLoad(True)

            BtnRefresh_Click(sender, e)
        Catch ex As Exception
            If ex.Message = "One or more errors occurred." Then
                MessageBox.Show("Cannot connect to firebase, check your network !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Me.Text = "VB Net Firebase RealTime Database"
            LabelRecordView.Text = "Record View"
            DisplayRecLoad(True)
        End Try
        '-------------------------------------------
    End Sub
    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        If dgv.RowCount = 0 Then
            AllCellsSelected = False
            Return AllCellsSelected
        End If
        AllCellsSelected = (dgv.SelectedCells.Count = (dgv.RowCount * dgv.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
        If dgv.RowCount = 1 Then
            AllCellsSelected = False
        End If
    End Function

    Private Sub BtnClearSelection_Click(sender As Object, e As EventArgs) Handles BtnClearSelection.Click

        DGVUserData.ClearSelection()
    End Sub

    Private Sub TBSearch_TextChanged(sender As Object, e As EventArgs)
        'dtTableGrd.DefaultView.RowFilter = CBSearchBy.Text & " Like '" & TBSearch.Text & "%'" 'To search for data on the DataGridView
        DGVUserData.ClearSelection()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

        BtnEdit_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        BtnDelete_Click(sender, e)
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click

        DGVUserData.SelectAll()
    End Sub

    Private Sub ClearSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearSelectionToolStripMenuItem.Click

        BtnClearSelection_Click(sender, e)
    End Sub

    Private Sub TBSearch_TextChanged_1(sender As Object, e As EventArgs) Handles TBSearch.TextChanged
        dtTableGrd.DefaultView.RowFilter = CBSearchBy.Text & " Like '" & TBSearch.Text & "%'" 'To search for data on the DataGridView
        DGVUserData.ClearSelection()
    End Sub

    Private Sub PictureBoxUserReg_Click_1(sender As Object, e As EventArgs) Handles PictureBoxUserReg.Click
        OpenFileDialogUserImage.FileName = ""
        OpenFileDialogUserImage.Filter = "JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg"

        If (OpenFileDialogUserImage.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            IMG_FileNameInput = OpenFileDialogUserImage.FileName
            PictureBoxUserReg.ImageLocation = IMG_FileNameInput
        End If
    End Sub
End Class
