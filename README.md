# geometricForms
Internet Programming 3 - Academic project based on C Sharp.

Descrição:
Todos os clientes do banco tem um id, um endereço, um número de telefone e um e-mail para contato, sendo todos esses dados obrigatórios na hora do cadastro. Sendo que é possível SOMENTE cadastrar dois tipos de Clientes: Pessoas Físicas e Pessoas Jurídicas.
 
Pessoas físicas tem um nome, sobrenome, rg, cpf e data de nascimento como campos obrigatórios. Os campos idade, faixa etária e renda são definidos automaticamente.


Pessoas jurídicas tem uma lista de sócios composto por pessoas físicas, cnpj, razão social, nome fantasia, Insc. Estadual e data abertura da empresa como campos obrigatórios. Já os campos Faturamento e Idade são automaticamente preenchidos.
 
Toda Conta aberta no banco deve ter um títular, que pode ser tanto uma pessoa física quanto uma pessoa jurídica. Além do número da conta e agência e uma taxa de saque. O saldo é definido como zero, sempre que uma conta for aberta. 
 
Este Banco permite abrir três tipos de conta:
Conta Salário: O saldo não pode ficar negativo. Permite apenas operação de saque, consulta o valor do Saldo e transferência para contas com mesmo títular e apenas para uma conta em que o titular da conta seja o mesmo da conta salário. A Conta salário não possui taxas!
 
Conta poupança: O saldo desse tipo de conta não pode ficar negativo. Há uma taxa de saque igual para todas as contas desse tipo. São permitidas operação de saque, depósito, transferência e consulta de saldo.


ContaCorrente: O atributo TipoConta pode ter o valor: SIMPLES ou ESPECIAL. Contas do tipo especial podem apenas ser abertas para pessoas físicas ou jurídicas com renda/faturamento superior à R$ 5.000,00. Toda conta corrente pode ficar com o saldo negativo, mas não pode ultrapassar o limite. O limite é calculado com base na renda, sendo 150% da renda para contas simples e 250% da renda para conta especial. A taxa de juros do limite da conta corrente é de 5% para contas simples e 2% para contas especiais.


A conta corrente permite operações de saque, depósito, transferência, pagamentos, consulta de saldo e empréstimos. 
Tabela Faixa etária

| Idade    | Categoria  |
|--------- |----------- |
| <=11     | criança    |
| 12 e 21  | jovem      |
| 22 e 59  | adulto     |
| >=60     | idoso      |
