# Managed Extensibility Framework (MEF)

## Breaking Change in MEF2 (compared to MEF1) - Cycling Reference

This repository shows a breaking change in MEF2, compared to MEF1.

Is there a work-around?

### MEF1

Im MEF1 it is possible to have a cycling reference between two components (see ClassA and ClassB in the sample),
even if the components are non-shared (``[PartCreationPolicy(CreationPolicy.NonShared)]``).

This is possible by using ``Lazy`` 

     public Lazy<ClassB> ClassB { get; set; }

### MEF2

Im MEF2 this is not working.

Is there a work-around?
