FROM node:latest
MAINTAINER shobhit kasliwal<skasliwal@liventus.com>

RUN npm install -g json-server

WORKDIR /fakeapi-data
VOLUME /fakeapi-data

EXPOSE 4301
EXPOSE 80
EXPOSE 8080

ADD run.sh /run.sh
ENTRYPOINT ["bash", "/run.sh"]
CMD []

#https://www.npmjs.com/package/the-fake-backend
#https://github.com/kengu/json-server-deployment