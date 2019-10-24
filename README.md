# Worldbuilding
Some examples of model use, terrain building, and level prototyping

It is not related to more narrative ideas of world building, if you want that try [here](http://worldbuilding.institute/), [there](https://medium.com/universe-factory/a-worldbuilding-checklist-4c1e88f7d1e6), and [everywhere](https://ieeexplore.ieee.org/stamp/stamp.jsp?arnumber=7790997).

Workshop covers the basics of:

+ Importing models, how should they be prepared? Good example - subdivided meshes w names, reusable parts, when set to static it doesn't freak out. Bad example, the NASA moon crater.
+ Making terrain, using brushes, why its optimised, how to make your own assets for it.
+ Introducing Mapbox, a tool for level design and locative media.
+ Using probuilder, overview and play time. Highlight export potential to give idea of multi part workflow e.g. prototype, playtest, export,model, import, playtest, optimise, import, playtest ... Rinse repeat.
+ Lighting: realtime and baked. Progressive or enlighten?
+ Optimising: LODs, GPU instancing

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
+ zero marker!
+ scale testing  

### Advice on breaking down complex object assemblies

+ Subdividing things: Hide the line!
+ Object focussed: split things up at logical divisions.

## Terrain

1. Draw a Terrain
2. Import a heightmap to generate a terrain

### Place Terrain object

+ Place a 3D Terrain object to make terrain. The default size of Terrain is quite large, 500 * 500.

### Add a texture

+ In the inspector of the Terrain object, select Paint Texture of the brush's icon .
+ Textures> Edit Textures> Add Texture> Select texture with Albedo Smoothness.
+ Then the whole Terrain object becomes the selected texture.
+ You can select multiple textures, you can change the texture depending on the place like drawing a picture with the Paint tool.

### Make unevenness

+ Choose the mountain icon Raise / Lower Terrain .
+ The place you clicked gets excited and becomes a mountain. Hold down the shift key and dent with a click.

### Plant a tree

+ Select Place Tree of tree icon . Edit Trees> Add Trees> Specify prefab of trees in Tree prefab.
+ After that, you can specify density in Mass Place Trees and place it in the whole Terrain object.
+ As with textures and terrain, you can add trees partly as you paint with paint tools.

### Plant the grass

+ Select the clover icon Paint Details .
+ In Edit details> Add Grass Texture, select texture for grass flowers "GrassFrond 01 Albedo Alpha" etc in Environment Assets.
+ After adjusting by adding color and size etc., you can plant grass as you draw with paint tool like other elements.

### Become scenery

+ Adjust variously, it will be like a landscape.

### Stylized level design ideas

+ Use processing or similar to make a pile of generative grass shapes
	+ grass can be approximated to a set of triangle strips.

![https://outerra.blogspot.com/2012/05/procedural-grass-rendering.html](https://2.bp.blogspot.com/-RZ1b5QNHPg8/T7-qQzKVmnI/AAAAAAAAASA/TwmXCvix8zA/s320/grass-strip.png)
+ Select a series of them and process them like the grass assets in the standard assetstore
+ Bang, weird world of freaky shapes.

### Useful links for Terrain Import/Export

+ Exporting your Unity terrain to Maya via Heightmap - <https://www.youtube.com/watch?v=LD0O1ic5Wx8>
+ Generating terrain from a Heightmap - <https://www.youtube.com/watch?v=VLTBYmmvLus> && <https://unity3d.college/2017/07/17/importing-real-world-terrain-unity-free-terrain-party/>
	+ [Download](https://terrain.party/) or make a heightmap with perlin noise or something.
	+ Check for mistakes: resize to something sensible, merge layers, convert to grayscale
	+ Save as RAW file, non-interleaved channels, unless you want cool glitches!
	+ Import file, setting Heightmap resolution in Unity to that of the file + 1

### Good examples of level design process

+ Hyperspeed process - https://www.youtube.com/watch?v=KCMHTG5n1Xo
+ A bit more chill - https://www.youtube.com/watch?v=IkRMMcPBFsc
+ Useful assets vid - https://www.youtube.com/watch?v=HRpD1FvXerA

## Mapbox
Mapbox provides a way to download maps for import to unity for level design and locative media like AR.

Goto [Mapbox Unity SDK](https://www.mapbox.com/unity/), register account and download SDK. Follow instructions on website for integration in unity and permissions.

+ Open CitySimulator scene
+ Select CitySimulatorMap GameObject, hit enable preview button.
+ Replace camera with Player prefab.
+ Notice the position and scale is whacky, adjust accordingly.
+ Press play, your player falls forever, so you must add a floor collider for the whole world.
	+ Inside CitySimulatorMap GameObject, undfold the Terrain tab
	+ Toggle Add Collider
+ Press play, enable fly mode and away you go!

### Creating a Mapbox

https://docs.mapbox.com/help/tutorials/create-a-map-in-unity/

+ Open Mapbox custom map scene, play with changing location; depending on where you go, you may need to change zoom level.
+ Inside the Map prefab:
	+ Set Latitude Longitude to: 36.2702, -121.8075
	+ Set unity tile size to 1000
	+ Set image data source to "Mapbox Satellite"
	+ Change the image data source to Custom style: mapbox://styles/vizrca/ck1uoums9092u1cpfog62soe2
	+ You can borrow or create your own styles using the online editor.

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





## Optimising

+ LODs - Level of detail groupings, set how things get rendered based on distance, its how the trees work in the terrain. <https://docs.unity3d.com/Manual/LevelOfDetail.html>
+ GPU Instancing - if you have a lot of the same objects, you can speed stuff up by using GPU instancing. Don't use this on unique objects! <https://docs.unity3d.com/Manual/GPUInstancing.html>
+ Occlusion culling - design your worlds so that the can be rendered in stages <https://docs.unity3d.com/Manual/OcclusionCulling.html>

## Shout-outs

Used the following free assets:

+ [GhostFreeRoamCamera](https://www.assetstore.unity3d.com/#!/content/19250?aid=1101lSqC): Free flying ghost roaming camera, in a FPS style!
+ [RTS camera](https://www.assetstore.unity3d.com/#!/content/43321?aid=1101lSqC): Best free camera asset on the Unity asset store.
+ [3rd Person Controller + Fly Mode](https://www.assetstore.unity3d.com/#!/content/28647?aid=1101lSqC): This package provides a basic setup for a 3rd person player controller. Includes scripts for the player movements, camera orbit and a Mecanim animator controller, containing basic locomotion (walk, run, sprint, aim & strafe, and also an extra fly mode).
+ [Nobiax/Yughues free materials and terrain assets](https://assetstore.unity.com/publishers/4986)
