<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.cbxRating = New System.Windows.Forms.ComboBox()
        Me.txtMovieTitle = New System.Windows.Forms.TextBox()
        Me.txtYearReleased = New System.Windows.Forms.TextBox()
        Me.btnAddMovie = New System.Windows.Forms.Button()
        Me.btnFindMovie = New System.Windows.Forms.Button()
        Me.btnDisplayAll = New System.Windows.Forms.Button()
        Me.btnDisplayByRating = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(182, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(208, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Label5"
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 15
        Me.lstDisplay.Location = New System.Drawing.Point(50, 209)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(360, 169)
        Me.lstDisplay.TabIndex = 5
        '
        'cbxRating
        '
        Me.cbxRating.FormattingEnabled = True
        Me.cbxRating.Items.AddRange(New Object() {"G", "PG", "MA", "R18"})
        Me.cbxRating.Location = New System.Drawing.Point(87, 78)
        Me.cbxRating.Name = "cbxRating"
        Me.cbxRating.Size = New System.Drawing.Size(121, 23)
        Me.cbxRating.TabIndex = 6
        '
        'txtMovieTitle
        '
        Me.txtMovieTitle.Location = New System.Drawing.Point(87, 41)
        Me.txtMovieTitle.Name = "txtMovieTitle"
        Me.txtMovieTitle.Size = New System.Drawing.Size(323, 23)
        Me.txtMovieTitle.TabIndex = 7
        '
        'txtYearReleased
        '
        Me.txtYearReleased.Location = New System.Drawing.Point(278, 78)
        Me.txtYearReleased.Name = "txtYearReleased"
        Me.txtYearReleased.Size = New System.Drawing.Size(100, 23)
        Me.txtYearReleased.TabIndex = 8
        '
        'btnAddMovie
        '
        Me.btnAddMovie.Location = New System.Drawing.Point(103, 107)
        Me.btnAddMovie.Name = "btnAddMovie"
        Me.btnAddMovie.Size = New System.Drawing.Size(75, 23)
        Me.btnAddMovie.TabIndex = 9
        Me.btnAddMovie.Text = "Add Movie"
        Me.btnAddMovie.UseVisualStyleBackColor = True
        '
        'btnFindMovie
        '
        Me.btnFindMovie.Location = New System.Drawing.Point(103, 137)
        Me.btnFindMovie.Name = "btnFindMovie"
        Me.btnFindMovie.Size = New System.Drawing.Size(75, 23)
        Me.btnFindMovie.TabIndex = 10
        Me.btnFindMovie.Text = "Find Movie"
        Me.btnFindMovie.UseVisualStyleBackColor = True
        '
        'btnDisplayAll
        '
        Me.btnDisplayAll.Location = New System.Drawing.Point(254, 107)
        Me.btnDisplayAll.Name = "btnDisplayAll"
        Me.btnDisplayAll.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplayAll.TabIndex = 11
        Me.btnDisplayAll.Text = "Display All Movies"
        Me.btnDisplayAll.UseVisualStyleBackColor = True
        '
        'btnDisplayByRating
        '
        Me.btnDisplayByRating.Location = New System.Drawing.Point(254, 137)
        Me.btnDisplayByRating.Name = "btnDisplayByRating"
        Me.btnDisplayByRating.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplayByRating.TabIndex = 12
        Me.btnDisplayByRating.Text = "By Rating"
        Me.btnDisplayByRating.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(103, 396)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 13
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(248, 396)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.btnDisplayByRating)
        Me.Controls.Add(Me.btnDisplayAll)
        Me.Controls.Add(Me.btnFindMovie)
        Me.Controls.Add(Me.btnAddMovie)
        Me.Controls.Add(Me.txtYearReleased)
        Me.Controls.Add(Me.txtMovieTitle)
        Me.Controls.Add(Me.cbxRating)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents cbxRating As ComboBox
    Friend WithEvents txtMovieTitle As TextBox
    Friend WithEvents txtYearReleased As TextBox
    Friend WithEvents btnAddMovie As Button
    Friend WithEvents btnFindMovie As Button
    Friend WithEvents btnDisplayAll As Button
    Friend WithEvents btnDisplayByRating As Button
    Friend WithEvents Clear As Button
    Friend WithEvents btnExit As Button
End Class
