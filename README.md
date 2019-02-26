# Worldbuilding
Some examples of model use, terrain building, and level prototyping

It is not related to more narrative ideas of world building, if you want that try [here](http://worldbuilding.institute/), [there](https://medium.com/universe-factory/a-worldbuilding-checklist-4c1e88f7d1e6), and [everywhere](https://ieeexplore.ieee.org/stamp/stamp.jsp?arnumber=7790997).

Workshop covers the basics of:

+ Importing models, how should they be prepared? Good example - subdivided meshes w names, reusable parts, when set to static it doesn't freak out. Bad example, the NASA moon crater.
+ Making terrain, using brushes, why its optimised, how to make your own assets for it.
+ Using probuilder, overview and play time. Highlight export potential to give idea of multi part workflow e.g. prototype, playtest, export,model, import, playtest, optimise, import, playtest ... Rinse repeat.
+ Lighting: realtime and baked. Progressive or enlighten?
+ Optimising: LODs, GPU instancing, statics

## Models and meshes

Some tools:
	+ Instant meshes
	+ Wrap 3 - free educational - good for characters, hands, faces, things that have references

### What does a bad mesh look like?

<https://sketchfab.com/3d-models/3d-body-scan-e3a72cad81f44c1a870cd21e34139e7e>

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

1. Draw a Terrain
2. Import a heightmap to generate a terrain

### Useful links for Terrain Import/Export

+ Exporting your Unity terrain to Maya via Heightmap - <https://www.youtube.com/watch?v=LD0O1ic5Wx8>
+ Generating terrain from a Heightmap - <https://www.youtube.com/watch?v=VLTBYmmvLus> && <https://unity3d.college/2017/07/17/importing-real-world-terrain-unity-free-terrain-party/>
	+ [Download](https://terrain.party/) or make a heightmap with perlin noise or something.
	+ Check for mistakes: resize to something sensible, merge layers, convert to grayscale
	+ Save as RAW file, non-interleaved channels, unless you want cool glitches!
	+ Import file, setting Heightmap resolution in Unity to that of the file + 1

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

## Lighting 

Many settings and takes a lot of time to figure out specifics related to your scenes.

Useful links for lighting:

+ <https://docs.unity3d.com/Manual/LightModes-TechnicalInformation.html>
+ <https://docs.unity3d.com/Manual/GI-Enlighten.html>
+ <https://docs.unity3d.com/Manual/ProgressiveLightmapper.html>



### Key Concepts

#### Realtime vs Baked Lighting

Realtime uses a set of algorithms that will allow lights to move and change in a scene.  Useful for illuminating characters or other movable geometry. Good example is a flash-light.

Unfortunately, realtime lights do not bounce when they are used by themselves. In order to create more detailed lighting scenes  techniques such as global illumination (GI) we need to enable Unity’s precomputed lighting solutions, Baking.

Baked lighting is a offline rendering of how lights interact in the scene. When 'baking’ a ‘lightmap', the effects of light on **static** objects in the scene are calculated and the results are written to textures which are overlaid on top of scene geometry to create the effect of lighting.

With baked lighting, these light textures (lightmaps) cannot change during gameplay and so are referred to as **static**. With this approach, we trade the ability to move our lights at gameplay for a potential increase in performance, suiting less powerful hardware such as mobile platforms or performance critical applications like VR.


**You must select what type of light each one is!**

#### Precomputed Realtime GI

Whilst traditional, static lightmaps are unable to react to changes in lighting conditions within the scene, Precomputed Realtime GI does offer us a technique for updating complex scene lighting interactively. **Best of both!**

A good example of this would be a time of day system - where the position and color of the light source changes over time. With traditional baked lighting, this is not possible.

#### What should I use?

The decision on which approach to take will have to be evaluated based on the nature of your particular project and desired target platform.

+ Realtime: Use Realtime mode for Lights that need to change their properties or which are spawned via scripts
 during gameplay. Unity calculates and updates the lighting of these Lights every frame at run time. They can change in response to actions taken by the player, or events which take place in the Scene. For example, you can set them to switch on and off (like a flickering light), change their Transforms (like a torch being carried through a dark room), or change their visual properties, like their color and intensity.
+ Mixed: Mixed Lights can change their Transform and visual properties (such as colour or intensity) during run time, but only within strong limitations. They illuminate both static and dynamic GameObjects, always provide direct lighting, and can optionally provide indirect lighting. Dynamic GameObjects lit by Mixed Lights always cast real-time shadows on other dynamic GameObjects.
+ Baked: Use Baked mode for Lights used for local ambience, rather than fully featured Lights. Unity pre-calculates the illumination from these Lights before run time, and does not include them in any run-time lighting calculations. This means that there is no run-time overhead for baked Lights.

#### Settings for lighting

Best place to get yourself up to speed is via Unity tutorial series on Graphics <https://unity3d.com/learn/tutorials/s/graphics>





## 

## Shout-outs

Used the following free assets:

+ [GhostFreeRoamCamera](https://www.assetstore.unity3d.com/#!/content/19250?aid=1101lSqC): Free flying ghost roaming camera, in a FPS style!
+ [RTS camera](https://www.assetstore.unity3d.com/#!/content/43321?aid=1101lSqC): Best free camera asset on the Unity asset store.
+ [3rd Person Controller + Fly Mode](https://www.assetstore.unity3d.com/#!/content/28647?aid=1101lSqC): This package provides a basic setup for a 3rd person player controller. Includes scripts for the player movements, camera orbit and a Mecanim animator controller, containing basic locomotion (walk, run, sprint, aim & strafe, and also an extra fly mode).
+ [Nobiax/Yughues free materials and terrain assets](https://assetstore.unity.com/publishers/4986)
