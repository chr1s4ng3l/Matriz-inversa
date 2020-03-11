'
' Created by SharpDevelop.
' User: Christopher
' Date: 14/02/2019
' Time: 09:46 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Dim A(1,3) As Double
	Dim r As Double
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	Sub Button2Click(sender As Object, e As EventArgs)
		Me.Close	
		
	End Sub
	
	Sub ButtonSumarClick(sender As Object, e As EventArgs)
		
		A(0,0)= Convert.ToDouble(textBoxA00.Text)	
		A(0,1)= Convert.ToDouble(textBoxA01.Text)	
		A(1,0)= Convert.ToDouble(textBoxA10.Text)	
		A(1,1)= Convert.ToDouble(textBoxA11.Text)	
		
		A(1,2)= 0
		A(1,3)= 1
		A(0,2)= 1
		A(0,3)= 0
		
		'		validamos 
		r= A(0,0) * A(1,1) - A(1,0) * A(0,1) 
		If r<>0 Then
			'			mandamos llamar los metodos
			inversa()
			llenar()
		Else 
			MsgBox("La matriz no tiene inversa")
		End If
	End Sub
	Sub inversa()
		
		
		Dim pivote As Double
		Dim aux As Double
		Dim m As Byte = 1
		'		convierte el 0,0 en 1
		For i As Integer = 0 To 1
			'	avanza
			For j As Integer = 0 To 1
				'	si i y j son 1,1
				If i = j Then
					'	se multimplica 1/el valor de 1,j 
					pivote = 1/A(i,j)
					'avanza a la siguiente fila
					For k As Integer = 0 To 3
						'	multimplicando la fila
						A(i,k) = A(i,k) * pivote
						
					Next k
					
					'convertimos en 0 
					aux = -1 * A(m,i)
					'avanza
					For k As Integer = 0 To 3
						'	
						A(m,k) =  aux * A(i,k) + A(m,k)
						
						
					Next k
					
					m=0
				End If
			Next j
		Next i
	End Sub
	Sub llenar()
		textBoxR00.Text=A(0,2).ToString("0.000")
		textBoxR01.Text=A(0,3).ToString("0.000")
		textBoxR10.Text=A(1,2).ToString("0.000")
		textBoxR11.Text=A(1,3).ToString("0.000")
	End Sub
End Class
