open System

let circleArea radius = Math.PI * radius

let cylinderVolume radius height = circleArea radius * height

Console.WriteLine(cylinderVolume 1. 2.)
