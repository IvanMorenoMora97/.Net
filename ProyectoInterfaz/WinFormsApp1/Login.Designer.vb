<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.iniciarSesion = New System.Windows.Forms.Label()
        Me.inputUsername = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.Label()
        Me.register = New System.Windows.Forms.LinkLabel()
        Me.password = New System.Windows.Forms.Label()
        Me.inputPassword = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'iniciarSesion
        '
        Me.iniciarSesion.AutoSize = True
        Me.iniciarSesion.Location = New System.Drawing.Point(62, 9)
        Me.iniciarSesion.Name = "iniciarSesion"
        Me.iniciarSesion.Size = New System.Drawing.Size(76, 15)
        Me.iniciarSesion.TabIndex = 0
        Me.iniciarSesion.Text = "Iniciar Sesión"
        '
        'inputUsername
        '
        Me.inputUsername.Location = New System.Drawing.Point(52, 106)
        Me.inputUsername.Name = "inputUsername"
        Me.inputUsername.Size = New System.Drawing.Size(100, 23)
        Me.inputUsername.TabIndex = 1
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Location = New System.Drawing.Point(49, 88)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(109, 15)
        Me.username.TabIndex = 2
        Me.username.Text = "Nombre de usuario"
        '
        'register
        '
        Me.register.AutoSize = True
        Me.register.Location = New System.Drawing.Point(62, 291)
        Me.register.Name = "register"
        Me.register.Size = New System.Drawing.Size(64, 15)
        Me.register.TabIndex = 3
        Me.register.TabStop = True
        Me.register.Text = "Registrarse"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Location = New System.Drawing.Point(62, 150)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(67, 15)
        Me.password.TabIndex = 4
        Me.password.Text = "Contraseña"
        '
        'inputPassword
        '
        Me.inputPassword.Location = New System.Drawing.Point(52, 168)
        Me.inputPassword.Name = "inputPassword"
        Me.inputPassword.Size = New System.Drawing.Size(100, 23)
        Me.inputPassword.TabIndex = 5
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(63, 213)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLogin.TabIndex = 6
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 315)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.inputPassword)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.register)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.inputUsername)
        Me.Controls.Add(Me.iniciarSesion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents iniciarSesion As Label
    Friend WithEvents inputUsername As TextBox
    Friend WithEvents username As Label
    Friend WithEvents register As LinkLabel
    Friend WithEvents password As Label
    Friend WithEvents inputPassword As TextBox
    Friend WithEvents ButtonLogin As Button
End Class
