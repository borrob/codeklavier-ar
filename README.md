# codeklavier-ar
AR extension by Patrick Borgeat for [CodeKlavier](https://codeklavier.space/) by Felipe Ignacio Noriega and Anne Veinberg.

https://codeklavier.space/arquatic

## Scenes

Each Scene builds its own app:

- **Visualizer** is a tool used by the pianist for coding/visualizng the structure of the L-Systems
- **ARTestbed** is a pre-vis tool for the final AR visuals but also used for Android devices that don't support ARCore
- **ARTestbed-Flyer** copy of the pre-vis tool but used to make high resolution screenshots with various backgrounds
- **TheAR** is the AR application (iOS, Android)

## Controls

### ARTestbed

Some keys can be used to toggle between different states and enable other features.

- **C** to toggle the display of the little center marker
- **R** to toggle automatic stage rotation
- **S** to toggle between the water sky box and a black background
- **F** to toggle if camera should follow active trees
- **M** to toggle to display the unity cage (1 cubic meter) and coordinate axis
- **O** hides the options button
- **X** take a high resolution screenshot (with alpha)

## Tech

Use in conjunction with the websockets server:
https://github.com/narcode/codeklavier-extras

## Acknowledgments

This repository includes the following third party packages/code
- [TextMesh Pro](https://assetstore.unity.com/packages/essentials/beta-projects/textmesh-pro-84126)
- [UnityOSC](https://github.com/jorgegarcia/UnityOSC)

[CodeKlavier](https://codeklavier.space/) is supported By Stimuleringsfonds Creatieve Industrie NL and other sponsors.