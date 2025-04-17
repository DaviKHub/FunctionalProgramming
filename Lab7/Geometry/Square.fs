module Geometry.Square

open GeometricFigure
open IPrint

type Square(sideLength) =
    inherit GeometricFigure()
    member val SideLength = sideLength with get, set

    override this.CalculateArea() = System.Math.Pow(sideLength, 2)

    override this.ToString() =
        sprintf "Square:  Side = %.3f, Area = %.3f" this.SideLength (this.CalculateArea())

    interface IPrint with
        member this.Print() = printfn "%s" (this.ToString())
