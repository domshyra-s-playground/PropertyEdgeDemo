# Introduction

TODO: Give a short introduction of your project. Let this section explain the objectives or the motivation behind this project.

# Property Edge Application

Add an application to IIS for PropertyEdge

# Using Visual Studio

1. Go Properties on the "Web" Project
2. Select the Web tab
3. Set the instance of IIS under the Servers section to Local IIS
4. Rename the project url to http://localhost/PropertyEdge
5. Click Create Virtual Directory

# Using IIS Manager

1. Select the Application named ProperyEdge
2. Open Authentication and make sure that Forms Authentication and Anonymous Authentication are enabled
3. Ensure that WSRB Solutions is set up in IIS. View the app-web-WsrbSolutions repository for instructions on setting that up
4. PropertyEdge will need you to sign in through WsrbSolutions


# 2023-11-16 - Getting Property Edge to run locally

1. Make sure you are running under Local IIS for PropertyEdge
2. For Project URL, I have it set to https://localhost/PropertyEdge
3. In your web.config, you will need to make sure your wsrbsolutions_auth property is set to your wsrbsolutions local host
4. You might also need to check your UserAccessConnStr and change the Password on it
5. It is probably easiest to adjust your MenuHelper.cs in WSRB Solutions to point to Property Edge, because it auto-encodes your username properly
6. I changed my Link to look like this:
    Link = "https://localhost/PropertyEdge/app/PropertyEdge";
7. Start up both Property Edge and WSRB Solutions
8. After logging into WSRB Solutions, you can navigate to Property Edge through the menu and it should work