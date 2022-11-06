#Text Conflict

To create the conflict i cloned the remote repository on local machine in 2 separate directories. From one directory i edited the file Program.cs and then pushed the changes. From the other repository i also edited the same file but i have not pulled before. When i wrote the command git push i got a message that i have to pull before. When i wrote the command git pull the conflict appeared because the same line of the file Program.cs was edited. To solve this, in Visual Studio i decided to keep the local version of line. Then i executed the command git merge --continue and after this i wrote the command git push.


#Removed file conflict

From one directory i deleted a file and pushed the changes to remote repository. From the other directory i have not pulled the changes, instead i edited that file ( added some lines). When i tried to push i got a message that i have to pull. When i wrote the command git pull i got the conflict. To solve this. from Visual Studio i clicked Keep the file, then the command git merge --continue and then git push.
