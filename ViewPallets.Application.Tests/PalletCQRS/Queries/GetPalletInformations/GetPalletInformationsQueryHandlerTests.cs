using Xunit;
using AutoMapper;
using Moq;
using ViewPallets.Domain.Entities;
using ViewPallets.Domain.Interfaces;
using ViewPallets.Application.Mappings;
using System.Threading;

namespace ViewPallets.Application.PalletCQRS.Queries.GetPalletInformations.Tests
{
    public class GetPalletInformationsQueryHandlerTests
    {
        [Fact()]
        public async void GetPalletInformationsQuery_NewPalletInformationsShouldReturnNull()
        {
            //arrange
            var pallet = new Pallet();

            var palletContextMock = new Mock<IPalletRepository>();
            palletContextMock.Setup(c => c.FindPalletDetails(pallet.PalletNumber!));

            var configuration = new MapperConfiguration(cfg => 
                cfg.AddProfile(new PalletMappingProfile()));

            var mapper = configuration.CreateMapper();

            var command = new GetPalletInformationsQuery()
            {
                palletNumberMediatR = pallet.PalletNumber!
            };

            var handler = new GetPalletInformationsQueryHandler(palletContextMock.Object, mapper);

            //act
            var handle = await handler.Handle(command, CancellationToken.None);

            //assert
            Assert.True(handle == null);
        }
    }
}