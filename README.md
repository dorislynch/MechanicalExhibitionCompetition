
# react-native-mechanical-exhibition-competition

## Getting started

`$ npm install react-native-mechanical-exhibition-competition --save`

### Mostly automatic installation

`$ react-native link react-native-mechanical-exhibition-competition`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-mechanical-exhibition-competition` and add `RNMechanicalExhibitionCompetition.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNMechanicalExhibitionCompetition.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNMechanicalExhibitionCompetitionPackage;` to the imports at the top of the file
  - Add `new RNMechanicalExhibitionCompetitionPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-mechanical-exhibition-competition'
  	project(':react-native-mechanical-exhibition-competition').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-mechanical-exhibition-competition/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-mechanical-exhibition-competition')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNMechanicalExhibitionCompetition.sln` in `node_modules/react-native-mechanical-exhibition-competition/windows/RNMechanicalExhibitionCompetition.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Mechanical.Exhibition.Competition.RNMechanicalExhibitionCompetition;` to the usings at the top of the file
  - Add `new RNMechanicalExhibitionCompetitionPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNMechanicalExhibitionCompetition from 'react-native-mechanical-exhibition-competition';

// TODO: What to do with the module?
RNMechanicalExhibitionCompetition;
```
  