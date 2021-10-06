# CS4555Project-Team5

NOTE: All assets that uploaded to the project are free to use assets.

1. (Component)
NPC -> If you going to create a new one !!!
- add NPC Script and uncheck it
- add Capsule Collider and change IsTrigger to check/true and the radius little bit bigger)

Directional Light -> Probably don't need it, not sure why KnM add it ?

Town -> Plate and Structure

PlayerController -> If you going to create a new one(please, Change Tag to "Player") !!!
-Player character(waiting for assest)
-Main Camera
-GroundCheck(require by the CharacterMovement script)

DialogueSystem -> Basic Dialogue
- Dialogue_GUI and below child component must be hide/uncheck before you run the game

EventSystem -> Probably don't need it, you can delete it.

NPC_GUI -> A canvas with child component text
- NPC and below child component must be hide/uncheck before you run the game


2. (Script)
CharacterMovement -> If you want to delete to delete it and add your own movement script, it won't affect the overall function. 

Cube Movement -> KnM created this script, use it for his testing purpose.

DialogueSystem -> 
Name Text -> Select Name from DialogueSystem
Diaglogue Text -> Select Diaglogue_Text from DialogueSystem
Dialogue GUI -> Select a canvas, NPC_GUI (To give user a hint of which input to pressdown to interact with the NPC)
Dialogue Box GUI ->  Select a canvas, Dialogue_GUI 
OTHER ... It's default

NPC -> (I think I messed up part of the code in NPC script, please change line 42,  dialogueSystem.name = Name; ->  dialogueSystem.Names = Name;
Chat Background -> Select Chat_Background from DialogueSystem
NPC Character -> Select NPC component itself
Name -> Any names you want 
Sentence -> Create 2~3, and write something down.






