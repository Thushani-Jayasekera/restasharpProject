cd  restsharpClient

dotnet build

dotnet run 

sudo sysctl -w net.inet.tcp.accurate_ecn=1  

tcpdump host prod2.thuhsnaidevenv.work.gd -w capturewithecn2209-devenv.pcap
