#!/bin/env /bin/bash

# releases https://github.com/apollographql/rover/releases
ROVER_VERSION="${ROVER_VERSION:-"v0.27.1"}"
ROVER_ARCHITECTURE="${ROVER_ARCHITECTURE:-"x86_64-unknown-linux-gnu"}"
BIN_PATH=./rover

BINARY_DOWNLOAD_PREFIX="https://github.com/apollographql/rover/releases/download"
ARCHIVE_NAME="rover-${ROVER_VERSION}-${ROVER_ARCHITECTURE}"

DOWNLOAD_URL="${BINARY_DOWNLOAD_PREFIX}/${ROVER_VERSION}/${ARCHIVE_NAME}.tar.gz"

echo "Downloading rover ${ROVER_VERSION} for ${ROVER_ARCHITECTURE} to '${BIN_PATH}'"

echo "Download link: ${DOWNLOAD_URL}"

curl --progress-bar -L -S "${DOWNLOAD_URL}" | tar -xzOf - dist/rover > "${BIN_PATH}"

chmod +x "${BIN_PATH}"

echo "Binary path: ${BIN_PATH}"
echo "Version: $("$BIN_PATH" -V)"
