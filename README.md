Run the restsharpClient client by following the steps below

1. Clone the repository 
```
git clone https://github.com/Thushani-Jayasekera/restasharpProject.git
```

2. Navigate to the project directory
```
cd restsharpClient
```

3. Build the project
```

```
dotnet build
```

4. Run the project
```
dotnet run
```

5. To enable sending ECN CWR Flags
```
sudo sysctl -w net.inet.tcp.accurate_ecn=1
```

6. To get a TCP DUMP
```
tcpdump host dev.thushanitest.work.gd -w capturewithecn2409-keepalivecon3.pca
```
