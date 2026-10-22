Imports System.Windows.Forms

Public Class FormColeccion

    ' Variable para llevar el número de peluches obtenidos
    Private peluchesGanados As Integer = 4
    Private Const TOTAL_PELUCHES As Integer = 30

    ' Este evento se ejecuta al abrir la ventana
    Private Sub FormColeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llama a la función para escribir el texto en el Label
        ActualizarTotal()
    End Sub

    ' ESTA ES LA FUNCIÓN (no es un botón) que actualiza el texto del Label "lblTotal"
    Private Sub ActualizarTotal()

    End Sub

    ' Evento para el botón VOLVER A JUGAR[cite: 3]
    Private Sub btnVolverJugar_Click(sender As Object, e As EventArgs) Handles btnVolverjugar.Click
        FormPeluches.Show()
        Me.Hide() ' Cierra la ventana para volver
    End Sub

    ' Evento para el botón CERRAR[cite: 3]
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close() ' Cierra la ventana
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolverjugar.Click

    End Sub
End Class