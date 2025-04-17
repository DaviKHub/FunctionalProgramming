module Geometry.Program

open Rectangle
open Square
open Circle
open IPrint
open GeometricFigureType

[<EntryPoint>]
let main (argv: string[]) =
    let rect = Rectangle.Rectangle(3.0, 4.0) :> IPrint
    let square = Square.Square(5.0) :> IPrint
    let circle = Circle.Circle(2.5) :> IPrint

    rect.Print()
    square.Print()
    circle.Print()

    let figures =
        [ GeometricFigureType.Rectangle(3.0, 4.0)
          GeometricFigureType.Square(5.0)
          GeometricFigureType.Circle(2.5) ]

    figures
    |> List.iter (fun figure ->
        match figure with
        | GeometricFigureType.Rectangle(width, height) -> printfn "Rectangle: area = %f" (calculateArea figure)
        | GeometricFigureType.Square(sideLength) -> printfn "Sqare: area = %f" (calculateArea figure)
        | GeometricFigureType.Circle(radius) -> printfn "Circle: area = %f" (calculateArea figure))

    0
