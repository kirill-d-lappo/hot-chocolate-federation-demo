#!/bin/env bash

# https://github.com/apollographql/router/releases

ROUTER_VERSION="${ROUTER_VERSION:-"v1.60.1"}"
ROUTER_ARCHITECTURE="${ROUTER_ARCHITECTURE:-"x86_64-unknown-linux-gnu"}"

echo "Downloading router ${ROUTER_VERSION} for ${ROUTER_ARCHITECTURE}"

DOWNLOAD_VERSION="$ROUTER_VERSION"
ARCHIVE_NAME="router-${DOWNLOAD_VERSION}-${ROUTER_ARCHITECTURE}"
BINARY_DOWNLOAD_PREFIX="https://github.com/apollographql/router/releases/download"

DOWNLOAD_URL="${BINARY_DOWNLOAD_PREFIX}/${DOWNLOAD_VERSION}/${ARCHIVE_NAME}.tar.gz"

BIN_PATH=./router

echo "Download link: ${DOWNLOAD_URL}"

curl --progress-bar -L -S "${DOWNLOAD_URL}" | tar -xzOf - dist/router >"${BIN_PATH}"

chmod +x "${BIN_PATH}"

echo "Binary path: ${BIN_PATH}"

echo "Version: $("$BIN_PATH" -V)"
