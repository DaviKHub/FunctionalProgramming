module Geometry.Rectangle

open System
open GeometricFigure
open IPrint

type Rectangle(width: double, height: double) =
    inherit GeometricFigure()

    member val Width = width with get, set
    member val Height = height with get, set

    override this.CalculateArea() = this.Width * this.Height

    override this.ToString() =
        sprintf "Rectangle: Width = %.3f, Height = %.3f, Area = %.3f" this.Width this.Height (this.CalculateArea())

    interface IPrint with
        member this.Print() = printfn "%s" (this.ToString())
