```
cd  restsharpClient
```

```
dotnet build
```

```
dotnet run
```

To enable sending ECN CWR Flags
```
sudo sysctl -w net.inet.tcp.accurate_ecn=1
```

To get a TCP DUMP
```
tcpdump host prod2.thuhsnaidevenv.work.gd -w capturewithecn2209-devenv.pcap
```
