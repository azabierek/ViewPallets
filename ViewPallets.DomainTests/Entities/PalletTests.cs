using Xunit;
using ViewPallets.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewPallets.Domain.Entities.Tests
{
    public class PalletTests
    {
        [Fact()]
        public void PalletTest_NewPalletShouldHavePredefinedValues()
        {
            //arrange
            var pallet = new Pallet();

            //act
            int intDefault = default(int);

            //assert
            Assert.False(pallet.PalletNumber == null);
            Assert.NotNull(pallet.PalletNumber);
            Assert.True(pallet.Length == intDefault);
        }

        [Fact()]
        public void SetPalletNumber_ShouldStartsWithPL()
        {
            //arrange 
            var pallet = new Pallet();

            //act

            //assert
            Assert.StartsWith("PL", pallet.PalletNumber);

        }
    }
}