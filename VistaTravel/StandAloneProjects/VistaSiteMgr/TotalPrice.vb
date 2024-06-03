Namespace VistaSiteMgr
    Public Class TotalPrice

        Inherits Pricing.BasePrice

        Overloads Overrides Function GetPrice(ByVal TotalCost As Double) As Double

            Const TaxRate = 0.1
            Dim Tax As Double

            'calculate the total price with tax
            Tax = TotalCost * TaxRate
            GetPrice = TotalCost + Tax
            
        End Function

        Overloads Function GetPrice(ByVal TotalCost As Double, ByVal TaxRate As Double) As Double
            
            Dim Tax As Double

            'calculate the total price with the specified tax rate
            Tax = TotalCost * TaxRate
            GetPrice = TotalCost + Tax
            
        End Function
    End Class
End Namespace
