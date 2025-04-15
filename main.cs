using System;
class HelloWorld {
  static void Main() {
  string continuar = "sim";
  int pedido;
  int estoquerefrigerante = 15, estoquehamburguer = 10, estoquebatata = 8, estoquesobremesa = 7;
  double precorefrigerante = 8.00, precohamburguer = 15.00, precobatata = 10.00, precosobremesa = 7.00;
  double totalpedido = 0;
  
    Console.WriteLine("Bem vindo a lanchonete XYZ!");
    Console.WriteLine("Aqui está o cardápio: ");
    Console.WriteLine("1 - Hambúrguer (R$ 15,00) - 10 disponíveis");
    Console.WriteLine("2 - Refrigerante (R$ 5,00) - 15 disponíveis");
    Console.WriteLine("3 - Batata Frita (R$ 10,00) - 8 disponíveis");
    Console.WriteLine("4 - Sobremesa (R$ 7,00) - 5 disponíveis");
    
    
    
   
   
    while(continuar == "sim"){
        
    Console.WriteLine("Faça seu pedido: ");
    pedido = int.Parse(Console.ReadLine());
            
        switch(pedido)
        {
        case 1:
        Console.WriteLine("Escolha quantos hamburguer vocẽ deseja");
        int qtdhamburguer = int.Parse(Console.ReadLine());
        
        
            if (estoquehamburguer >= qtdhamburguer)
            {
                estoquehamburguer -= qtdhamburguer; 
                totalpedido += qtdhamburguer * precohamburguer;
                Console.WriteLine("pedido registrado " + qtdhamburguer.ToString());
            } else {
                 Console.WriteLine("Não temos estoque suficiente. Temos apenas " + estoquehamburguer + "disponiveis.");
            } 
            break;
            
            
        case 2:
        Console.WriteLine("Escolha quantos refrigerante vocẽ deseja");
        int qtdrefrigerante = int.Parse(Console.ReadLine());
        
        
            if (estoquerefrigerante >= qtdrefrigerante)
            {
                estoquerefrigerante -= qtdrefrigerante; 
                totalpedido += qtdrefrigerante * precorefrigerante;
                Console.WriteLine("pedido registrado " + qtdrefrigerante.ToString());
            } else {
                 Console.WriteLine("Não temos estoque suficiente. Temos apenas " + estoquerefrigerante + "disponiveis.");
            } 
            break;
        case 3:
        Console.WriteLine("Escolha quantos batata frita vocẽ deseja");
        int qtdbatata = int.Parse(Console.ReadLine());
        
        
            if (estoquebatata >= qtdbatata)
            {
                estoquebatata -= qtdbatata; 
                totalpedido += qtdbatata * precobatata;
                Console.WriteLine("pedido registrado " + qtdbatata.ToString());
            } else {
                 Console.WriteLine("Não temos estoque suficiente. Temos apenas " + estoquebatata + "disponiveis.");
            } 
            break;
        
        case 4:
        Console.WriteLine("Escolha quantas sobremesa vocẽ deseja");
        int qtdsobremesa= int.Parse(Console.ReadLine());
        
        
            if (estoquesobremesa >= qtdsobremesa)
            {
                estoquesobremesa -= qtdsobremesa; 
                totalpedido += qtdsobremesa * precosobremesa;
                Console.WriteLine("pedido registrado " + qtdsobremesa.ToString());
            } else {
                 Console.WriteLine("Não temos estoque suficiente. Temos apenas " + estoquesobremesa + "disponiveis.");
            } 
            break;
            
        default:Console.WriteLine("Numero invalido");break;
        } 
    Console.WriteLine("");
    Console.WriteLine("Deseja fazer um novo pedido?(sim/nao)");
    continuar = Console.ReadLine().ToLower();
    }
    
    //Metodo de pagamento 
    
    Console.WriteLine($"Total do pedido {totalpedido}");
    
    Console.WriteLine("Escolha o metodo de pagamento");
    Console.WriteLine("1 - Dinheiro");
    Console.WriteLine("2 - Cartao de credito");
    Console.WriteLine("3 - Pix");
    Console.WriteLine("Escolha: ");
    int metodo = int.Parse(Console.ReadLine()); 
    
    switch(metodo)
    {
        case 1: Console.WriteLine("Pagamento realizado com sucesso em dinheiro. Obrigado!"); break;
        case 2: Console.WriteLine("Pagamento realizado com sucesso no cartão de crédito. Obrigado!"); break;
        case 3: Console.WriteLine("Pagamento realizado com sucesso via Pix. Obrigado!"); break;
        default: Console.WriteLine("metodo invalido "); break;
    }
  }
}