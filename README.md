# Bl0g.Content.ConsoleApp
This isn't yet done. This component has the ability to fetch files from a source, parse, and load it into the database, for all to read.

# Format
There exists two files:

1. Metadata - a XML file with some descriptive data
2. Actual content - a markdown file with the content

They need to be named the same, fx 

* AzureFunctions.xml
* AzureFunctions.md


## Metadata
The format is on the form

   <?xml version="1.0" encoding="utf-8"?>
   <!--state can be Draft/Publish/RePublish-->
   <!--date times is on following format 2008-09-22T14:01:54.9571247Z year-month-day-->
   <information 
   state="Published" 
   publishtime="2019-04-01T21:01:54.9571247Z" 
   headline="Azure Functions: Tips og Tricks" 
   author="Martin Slot" tags="ioc, azure-functions" 
   creationtime="2019-04-01T21:01:54.9571247Z" 
   id="" 
   rev="" />
   
The id and rev is filled if it is imported, so an editor can always head back to, update the markdown file, set the state to "RePublish" and then the app will reimport it, and set the rev properly.

## Actual content
This is a plain old markdown file as we know it.

# More to come
When I finish this part, I will update the this file accordingly.
