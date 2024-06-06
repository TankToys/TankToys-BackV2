using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using TankToys.Models;

namespace TankToys.Utils;

public static class JWT
{
	public static string GenerateJWTToken(User user)
	{
		var claims = new List<Claim> {
				new("address", user.Id.ToString()),
				new("username", user.Username),
		};

		var jwtToken = new JwtSecurityToken(
				claims: claims,
				notBefore: DateTime.UtcNow,
				expires: DateTime.UtcNow.AddDays(30),
				signingCredentials: new SigningCredentials(
						new SymmetricSecurityKey(
							 Encoding.UTF8.GetBytes("pipo es un buen perro para llamarse pipo")
								),
						SecurityAlgorithms.HmacSha256Signature)
				);
		return new JwtSecurityTokenHandler().WriteToken(jwtToken);
	}
}