#!/bin/bash

args="$@"

args="$@ -p 80"

file=/fakeapi-data/db.json
if [ -f $file ]; then
    echo "Found db.json, trying to open"
    args="$args db.json"
fi

file=/fakeapi-data/file.js
if [ -f $file ]; then
    echo "Found file.js seed file, trying to open"
    args="$args file.js"
fi

file=/fakeapi-data/route.json
if [ -f $file ]; then
    echo "Found route.json route file, trying to open"
    args="$args -r route.json"
fi

json-server $args