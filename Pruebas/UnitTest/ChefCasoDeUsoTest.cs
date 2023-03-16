using CasosdeUso.DDD.Dominio.CasosdeUso;
using CasosdeUso.DDD.Dominio.Gateways;
using Catering.DDD.Dominio.Chef.Comandos;
using Catering.DDD.Dominio.Generics;
using Moq;
using Pruebas.Builders;
using Pruebas.Builders.Chef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.UnitTest
{
    public class ChefCasoDeUsoTest
    {
        private readonly Mock<IStoredEventRepository<StoredEvent>> _mockRepository;


        public ChefCasoDeUsoTest()
        {
            _mockRepository = new();
        }

        [Fact]
        public async Task CrearChef()
        {

            //Arrange
            _mockRepository.Setup(repo => repo.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(GetStoredEvent());

            _mockRepository.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult<int>(200));
            //Act
            var useCase = new ChefCasodeUso(_mockRepository.Object);
            await useCase.CrearChef(CrearChefComando());
            //Assert
            _mockRepository.Verify(r => r.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()), Times.Exactly(4));
            _mockRepository.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));
        }



        private CrearChefComando CrearChefComando() =>
            new CrearChefBuilder()
                .WithName("Jesus")
                .WithCedula(0)
                .WithCorreo("Jesus@gmail.com")
                .WithExperiencia("Dos anios")
                .WithIdiomas("Aleman")
                .WithContrato("Por dia")
                .WithFormaPago("Efectivo")
                .WithEspecialidad("Postres")
                .Build();

        private StoredEvent GetStoredEvent() =>
            new StoredEventBuilder()
                .WithStoredId(1)
                .WithStoredName("StudentCreated")
                .WithAggregateId("Aggregate1")
                .WithEventBody("{\"Type\":\"chef.creado\",\"ChefID\":\"5387a47d - 98ea - 40cd - 8c65 - 8dd93e98a4b3\"}")
                .Build();

    }
}
