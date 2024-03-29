﻿using IP_Web.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace IP_Web.Extensions;

public static class AddJwtTokenServicesExtension
{
    public static void AddJWTTokenServices(this IServiceCollection Services, IConfiguration Configuration)
    {
        // Add Jwt Setings
        var bindJwtSettings = new JwtSettings();
        Configuration.Bind("JsonWebTokenKeys", bindJwtSettings);
        Services.AddSingleton(bindJwtSettings);
        Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.RequireHttpsMetadata = false;
            options.SaveToken = true;
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = bindJwtSettings.ValidateIssuerSigningKey,
                IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(bindJwtSettings.IssuerSigningKey)),
                ValidateIssuer = bindJwtSettings.ValidateIssuer,
                ValidIssuer = bindJwtSettings.ValidIssuer,
                ValidateAudience = bindJwtSettings.ValidateAudience,
                ValidAudience = bindJwtSettings.ValidAudience,
                RequireExpirationTime = bindJwtSettings.RequireExpirationTime,
                ValidateLifetime = bindJwtSettings.RequireExpirationTime,
                ClockSkew = TimeSpan.FromDays(1),
            };
        });
    }
}
