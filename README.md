# Son of Cod Seafood Site

Son of Cod Seafood is a fictional entity and is not intended to mimic or represent any real world entity or intellectual property. This site is a simple mockup marketing site with a newsletter sign-up feature. There is an admin portal that allows site admins to log in and view the current mailing list or create new admins.

The styling of the site was very loosely inspired by [Pacific Seafood](https://www.pacseafood.com/home).


## Setup and Install

#### Prerequisites

You will need the following things properly installed on your computer.

* [Git](https://git-scm.com/)
* [Microsoft Visual Studio](https://www.visualstudio.com/downloads/)
* [Microsoft SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms#sql-server-management-studio)

#### Installation

Clone this repository and open the solution file `SonOfCod.sln` in Visual Studio. Open SSMS and connect to `(localdb)mssqllocaldb`, and run the script in the `SonOfCodDB.sql` file to create the local database. You can log in to the admin portal with email `admin@admin` and password `123qweA!`.

## Known Bugs

None documented right now, but I'm sure there are plenty.

## Possible future version features

* Add better styling overall.
* Add error prevention to signup forms.
* Add error prevention to Admin functions.

## Support and contact details

If you have questions or comments, contact the author at bradcopenhaver@gmail.com

## Technologies Used

* ASP.NET CORE
* C#
* html/css
* Bootstrap

### License

This project is licensed under the MIT license.

Copyright (c) 2017 **Brad Copenhaver**
