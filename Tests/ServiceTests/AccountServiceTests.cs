// using Microsoft.EntityFrameworkCore;
// using Norwyn.App.Data;
// using Norwyn.App.Models;
// using Norwyn.App.Services;
// using Norwyn.Services.Account;
// using Xunit;
//
// namespace Tests.ServiceTests
// {
//     public class AccountServiceTests
//     {
//         private ApplicationDbContext GetInMemoryDbContext()
//         {
//             var options = new DbContextOptionsBuilder<ApplicationDbContext>()
//                 .UseInMemoryDatabase(databaseName: "TestDb")
//                 .Options;
//
//             return new ApplicationDbContext(options);
//         }
//
//         
//         [Fact]
//         public async Task RegisterUserAsync_ShouldAddUser_WithTestData()
//         {
//             // Given
//             var dbContext = GetInMemoryDbContext();
//             var service = new AccountService(dbContext);
//
//             var model = new SignUpViewModel
//             {
//                 Email = "BRB@gmail.com",
//                 Password = "Password123",
//                 FullName = "Pietie"
//             };
//
//             // When
//             var result = await service.RegisterUserAsync(model);
//
//             // Then
//             Assert.True(result); 
//             var userInDb = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == "BRB@gmail.com");
//             Assert.NotNull(userInDb);
//             Assert.Equal("Pietie", userInDb.UserName);
//             Assert.Equal("Password123", userInDb.Password);
//         }
//     }
// }
