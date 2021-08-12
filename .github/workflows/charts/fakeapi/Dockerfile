FROM node:latest
MAINTAINER shobhit kasliwal<skasliwal@liventus.com>

RUN npm install -g json-server

WORKDIR /fakeapi-data
VOLUME /fakeapi-data

EXPOSE 4301
ADD run.sh /run.sh
ENTRYPOINT ["bash", "/run.sh"]
CMD []