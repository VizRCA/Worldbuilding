# Worldbuilding
Some examples of model use, terrain building, and level prototyping

It is not related to more narrative ideas of world building, if you want that try [here](http://worldbuilding.institute/), [there](https://medium.com/universe-factory/a-worldbuilding-checklist-4c1e88f7d1e6), and [everywhere](https://ieeexplore.ieee.org/stamp/stamp.jsp?arnumber=7790997).

Workshop covers the basics of:

+ Importing models, how should they be prepared? Good example - subdivided meshes w names, reusable parts, when set to static it doesn't freak out. Bad example, the NASA moon crater.
+ making terrain, using brushes, why its optimised, how to make your own assets for it.
+ Using probuilder, overview and play time. Highlight export potential to give idea of multi part workflow e.g. prototype, playtest, export,model, import, playtest, optimise, import, playtest ... Rinse repeat.
+ Optimising: LODs, GPU instancing, statics
+ lighting: realtime and baked. Progressive or enlighten?

## Models and meshes

Some tools:
	+ Instant meshes
	+ Wrap 3 - free educational - good for characters, hands, faces, things that have references
  
### Importing models

+ correct uv's and normals, do topology tests in modelling software.
+ blocking out model shapes with collider's, complex mesh collider's are expensive.
+ well structured models in your modelling software will be well structured on import.
+ zero marker
+ scale testing  
  
### Advice on breaking down complex object assemblies

+ Subdividing things: Hide the line!
+ Object focussed: split things up at logical divisions.

## Terrain 

See slides

## Probuilder

hold SHIFT to extrude based on transform tool

In EDGE mode, double click will pick a selection connected to selected vertex

RED ICONS change geometry, eg flip normal

BLUE ICONS selection tools

GREEN ICONS object tools, mirror etc

ORANGE ICONS shape tools

You can export models! Then do proper modelling. Prototyping is a series of stages.

Materials, load them in ALT + num

UV Editor, shape the direction of texture mapping.

Created objects have colliders.

## Shout-outs

Used the following free assets:

+ [GhostFreeRoamCamera](https://www.assetstore.unity3d.com/#!/content/19250?aid=1101lSqC): Free flying ghost roaming camera, in a FPS style!
+ [RTS camera](https://www.assetstore.unity3d.com/#!/content/43321?aid=1101lSqC): Best free camera asset on the Unity asset store.
+ [3rd Person Controller + Fly Mode](https://www.assetstore.unity3d.com/#!/content/28647?aid=1101lSqC): This package provides a basic setup for a 3rd person player controller. Includes scripts for the player movements, camera orbit and a Mecanim animator controller, containing basic locomotion (walk, run, sprint, aim & strafe, and also an extra fly mode).
