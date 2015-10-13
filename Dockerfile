FROM mono

RUN mkdir '/home/injestix-api'
ADD / /home/injestix-api

RUN mono nuget restore /home/injestix-api/injestix-api.sln &&  xbuild /home/injestix-api/injestix-api.sln

ENTRYPOINT ["mono", "/home/injestix-api/Injestix.Gateway/bin/Debug/Injestix.Gateway.exe"]
