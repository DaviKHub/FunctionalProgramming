module Geometry.GeometricFigure

[<AbstractClass>]
type GeometricFigure() =
    abstract member CalculateArea: unit -> double
    override this.ToString() = $"Area: %.3f{this.CalculateArea()}"
