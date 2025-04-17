module Geometry.GeometricFigureType

type GeometricFigureType =
    | Rectangle of width: double * height: double
    | Square of sideLength: double
    | Circle of radius: double

let calculateArea figure =
    match figure with
    | Rectangle (width, height) -> width * height
    | Square (sideLength) -> sideLength * sideLength
    | Circle (radius) -> System.Math.PI * radius * radius
