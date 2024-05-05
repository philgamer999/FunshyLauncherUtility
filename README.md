# FunshyLauncherUtility

## Description
 This is a Launcher mainly for [GoogleDrive](https://drive.google.com) files. It's purpose is to update and launch files.

## Installation And Setup
In order to setup your project, you can use the following steps:
1. Compress your file(s) to a .ZIP file.

2. Upload the ZIP-file to GoogleDrive.

3. Upload a .txt file containing the file version to GoogleDrive.

4. Create a link to both files. Accessible for "everyone with link".

5. Copy the File-IDs: <br>
https://drive.google.com/file/d/kl1mpfZPsWG6Oqu8mOcGJsAZAcq3fnT1/view?usp=sharing <br>
File-ID: `kl1mpfZPsWG6Oqu8mOcGJsAZAcq3fnT1`

6. Visit https://console.cloud.google.com/ and create an API-Key. [Further information here](https://bytesbin.com/skip-google-drive-virus-scan-warning-large-files/) <br>
API-Key: `bYLnK6Wgwec6pmdvnfJYMTVnPcbNpbRP`

7. Copy the API-Key and the File-ID and paste them in this template: [Further information here](https://bytesbin.com/skip-google-drive-virus-scan-warning-large-files/) <br>
https://www.googleapis.com/drive/v3/files/File-ID?alt=media&#38;key=API-Key <br>
https://www.googleapis.com/drive/v3/files/kl1mpfZPsWG6Oqu8mOcGJsAZAcq3fnT1?alt=media&#38;key=bYLnK6Wgwec6pmdvnfJYMTVnPcbNpbRP <br>

8. After starting and clicking "Create" 

- Choose a name.

- Enter the name of the file you want to be launched with extension.

- Paste the links in it's respective Fields.

- If of interest add a description.

In order to update your application, you can upload a new version to the GoogleDrive file's "Version Manager". 
That way the ID stays the same.
