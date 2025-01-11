# Polymorphism Example

This project demonstrates the concept of polymorphism in object-oriented programming. The goal is to calculate the area of geometric shapes such as squares, rectangles, and right triangles using a common base class.

## Classes and Properties

### BaseGeometrikSekil (BaseGeometricShape)
- **Properties:**
  - `Genislik` (Width)
  - `Yukseklik` (Height)
- **Methods:**
  - `AlanHesapla()` (CalculateArea): A method that is overridden by derived classes to calculate the area specific to each shape.

### Kare (Square)
- **Inherits:** `BaseGeometrikSekil`
- **Area Calculation:**
  - Width × Height

### Dikdortgen (Rectangle)
- **Inherits:** `BaseGeometrikSekil`
- **Area Calculation:**
  - Width × Height

### DikUcgen (RightTriangle)
- **Inherits:** `BaseGeometrikSekil`
- **Area Calculation:**
  - (Width × Height) ÷ 2

## Example Usage

The program creates instances of `Kare`, `Dikdortgen`, and `DikUcgen` classes, assigns values to their properties, and calls their `AlanHesapla` method to display the area for each shape.

## How It Works
1. The `BaseGeometrikSekil` class defines shared properties (`Genislik` and `Yukseklik`) and a virtual method (`AlanHesapla`) to calculate the area.
2. The derived classes (`Kare`, `Dikdortgen`, and `DikUcgen`) override the `AlanHesapla` method to implement shape-specific area calculations.
3. Instances of each shape are created, their properties are initialized with sample values, and the overridden `AlanHesapla` methods are called to calculate their areas.

## Output
```
Kare Alanı: 25
Dikdörtgen Alanı: 28
Dik Üçgen Alanı: 24
