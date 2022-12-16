﻿namespace BitMono.Obfuscation;

public class BitMonoContextCreator
{
    private readonly IDependenciesDataResolver m_DependenciesDataResolver;
    private readonly IConfiguration m_Configuration;

    public BitMonoContextCreator(IDependenciesDataResolver dependenciesDataResolver, IBitMonoObfuscationConfiguration configuration)
    {
        m_DependenciesDataResolver = dependenciesDataResolver;
        m_Configuration = configuration.Configuration;
    }

    public BitMonoContext Create(string outputDirectoryName, string fileName)
    {
        return new BitMonoContext
        {
            OutputDirectoryName = outputDirectoryName,
            DependenciesData = m_DependenciesDataResolver.Resolve(),
            Watermark = m_Configuration.GetValue<bool>(nameof(Shared.Models.Obfuscation.Watermark)),
            FileName = fileName,
        };
    }
}