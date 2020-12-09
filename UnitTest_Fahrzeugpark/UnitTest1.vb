Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Fahrzeugpark

Namespace UnitTest_Fahrzeugpark

    'UNIT-TESTS sind simple �berpr�fungen, mit denen kleine Programmteile �ber l�ngere Zeit auf ihre korrekte
    ''Funktionalit�t hin �berpr�ft werden k�nnen. Ausgef�hrt werden diese �ber das 'Test'-Men�
    <TestClass>
    Public Class UnitTest_PKW

        <TestMethod>
        Sub Beschleunige_ueber_MaxG()

            Dim pkw1 = New PKW("BMW", 280, 30000, 5)

            pkw1.StarteMotor()
            pkw1.Beschleunige(pkw1.MaxGeschwindigkeit + 1)

            'Jede TestMethod muss mindestens einen Zugriff auf die Assert-Klasse nehmen, mit deren Methoden die
            ''zu �berpr�fenden Programmteile getestet werden. Ein Test gilt als erfolgreich, wenn alle Assert-Methoden
            ''in einer TestMethod ein true zur�ckgeben.
            Assert.AreEqual(pkw1.MaxGeschwindigkeit, pkw1.AktGeschwindigkeit)

        End Sub

        <TestMethod>
        Sub Bremse_unter_0()

            Dim pkw1 = New PKW("BMW", 280, 30000, 5)

            pkw1.StarteMotor()
            pkw1.Beschleunige(50)
            pkw1.Beschleunige(-pkw1.AktGeschwindigkeit - 1)

            Assert.AreEqual(0, pkw1.AktGeschwindigkeit)

        End Sub

    End Class

End Namespace

