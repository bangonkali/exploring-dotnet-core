## Publishing

(Install Platform on OS of Choice)[http://getdotnet.azurewebsites.net/target-dotnet-platforms.html]

More info (here)[https://docs.microsoft.com/en-us/dotnet/articles/core/deploying/index].

```
dotnet publish -c release -r win10-x64
dotnet publish -c release -r osx.10.10-x64
```

## MySQL on MAC

Copy CNF to allow network publish.

```
cd /usr/local/mysql/support-files/
sudo cp my-huge.cnf /etc/my.cnf
```

Allow users to connect remotely.
```
GRANT ALL ON *.* to user@'%' IDENTIFIED BY 'password'; 
```