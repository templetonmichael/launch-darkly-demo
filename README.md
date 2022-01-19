# How to Use this Demo

### Step 1: Create the 'test-bool' feature flag.
 - Within the Launch Darkly dashboard, navigate to 'Feature Flags' using the menu on the left
 - Click the 'Create Flag' button to make a new feature flag
 - Name your feature flag 'test-bool'
 - Under 'Client-side SDK availability', check the box for 'SDKs using Mobile key'
 - Using the 'Flag Variations' dropdown, select 'Boolean'
 - Leave the 'Default Variations' as-is, and click 'Save Flag' 
 - Your new feature flag should now be created across your Launch Darkly environments.

### Step 2: Set up targeting for a specific user
 - Within the Launch Darkly dashboard, navigate to your newly created 'test-bool' feature flag.
 - Under 'Target individual users', select 'Add user targets'
 - Select the 'Add Users' dropdown under the 'true' variation, and add 'valid_user'
 - NOTE: User targeting is environment specific, so 'valid_user' will only be added to your current environment
### Step 3: Clone or download a copy of this repository

### Step 4: Use your Mobile SDK Key
 - Within the Launch Darkly dashboard, navigate to 'Account Settings' using the menu on the left
 - Select the 'Projects' tab
 - Find the Mobile Key for the same environment in which you set up your 'valid_user', and copy it onto your clipboard
 - Open the 'LaunchDarklyDao.cs' file from the repository you just cloned
 - On line 13, replace "YOUR MOBILE SDK KEY HERE" with the sdk key you just copied

### Step 5: Running the Console Application
 - Start running the console application
 - Your output window should display some logs about starting the Launch Darkly client, and 'Launch Darkly Feature Flag Result: False' if you haven't turned on targeting for the 'test-bool' flag
 - Within the Launch Darkly dashboard, navigate to the 'test-bool' feature flag and turn targeting on, and save your changes.
 - If you run the console application again, you should now see 'Launch Darkly Feature Flag Result: True'. 
 - If you'd like to see how user targeting works, try changing 'valid_user' on line 9 of LaunchDarklyDao.cs, run the application again, and it should return false.
