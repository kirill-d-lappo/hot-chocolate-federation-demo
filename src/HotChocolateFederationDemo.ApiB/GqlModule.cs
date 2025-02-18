[assembly: Module("ApiBTypes")]
[assembly: DataLoaderModule("ApiBDataLoaders")]
[assembly:
  DataLoaderDefaults(
    AccessModifier = DataLoaderAccessModifier.PublicInterface,
    ServiceScope = DataLoaderServiceScope.DataLoaderScope
  )]
