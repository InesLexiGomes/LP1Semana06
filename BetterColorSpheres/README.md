# Better Color Spheres

```mermaid
---
title: Class Diagram
---
classDiagram
    Program --|> Color
    Sphere --|> Color
    Program --|> Sphere
    class Program{
        
    }
    class Sphere{
        - color: Color
        + Radius: uint
        + TimesThrown: uint
        + Pop() void
        + Throw() void
        + printStatus() void
        + Sphere() void
    }

    
```
