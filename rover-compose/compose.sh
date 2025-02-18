schema=./a-n-b-schema.yaml

./rover supergraph compose --config=config-rover.yaml --output="$schema"

# required by router
APOLLO_ELV2_LICENSE=accept

./router --supergraph="$schema" --config=config-router.yaml --hot-reload --dev