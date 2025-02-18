schema=./a-n-b-schema.yaml

rm "$schema"

./rover supergraph compose --config=config-rover.yaml --output="$schema"

if [[ " $? " -ne " 0 " ]]; then
  echo "Supergraph was not built, exiting..."
  exit 1
fi

# required by router
APOLLO_ELV2_LICENSE=accept

./router --supergraph="$schema" --config=config-router.yaml --hot-reload --dev
