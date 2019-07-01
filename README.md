1. Creare Applicazione Web ASP.NET Core
2. Applicazione Web MVC

1. Aggiungere classi modelli
	prop
	[Rel 1 a molti] -> FK più oggetto (Customer)/ Lista di oggetti(Orders)
	Costruttore vuoto (obbligatorio)
	costruttore con tutto
	
2. Context che estende DbContext
	DbSets
	Factory per le migrations
	
3. Fare migrations

4. Aggiungere controller
	Controller MVC con visualizzazioni, che usa Entity Framework -> Scaffolding
	Classe modello: 
	Classe contesto -> Quella che estende DbContext
	Lasciare tutte le spunte
	Nome cliente
	
	Controllare il tutto
	
	Aggiungere i metodi mancanti
