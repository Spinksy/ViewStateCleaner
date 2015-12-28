
View State Cleaner
=

__Todo__
- Loop through xaml files in post build event (powershell?)

**Done**
- Add ViewStateCleaning Writer to DocGen Solution 
 - Need to set the local assembly property when instantiating the XamlXmlReader so that custom activity types can be inferred
	- Set the local assembly property of XamlXmlReaderSettings by obtaining the assembly from one of the types contained in the required assembly
 - Add Reference to the Workflow Project
 - Add a new folder to the Workflow project, to hold cleaned workflows
  - Pre build event, empties cleaned workflows folder
  - Post build event, copies xml files
