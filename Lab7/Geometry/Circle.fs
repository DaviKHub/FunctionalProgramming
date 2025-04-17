module Geometry.Circle

open GeometricFigure
open IPrint

type Circle(radius: double) =
    inherit GeometricFigure()
    member val Radius = radius with get, set

    override this.CalculateArea() =
        System.Math.PI * System.Math.Pow(radius, 2)

    override this.ToString() =
        sprintf "Circle: Radius = %.3f, Area = %.3f" this.Radius (this.CalculateArea())

    interface IPrint with
        member this.Print() = printfn "%s" (this.ToString())
