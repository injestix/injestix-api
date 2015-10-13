FROM mono

RUN mkdir '/home/injestix-api'
ADD / /home/injestix-api

RUN nuget restore /home/injestix-api/injestix-api.sln &&  xbuild /home/injestix-api/injestix-api.sln

EXPOSE 8181

ENTRYPOINT ["mono", "/home/injestix-api/Injestix.Gateway/bin/Debug/Injestix.Gateway.exe"]
