[assembly: Module("ApiATypes")]
[assembly: DataLoaderModule("ApiADataLoaders")]
[assembly:
  DataLoaderDefaults(
    AccessModifier = DataLoaderAccessModifier.PublicInterface,
    ServiceScope = DataLoaderServiceScope.DataLoaderScope
  )]