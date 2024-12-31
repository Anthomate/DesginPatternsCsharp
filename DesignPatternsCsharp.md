# Design Patterns en C#

## Introduction
En 1995, le **Gang Of Four** (GoF) a introduit dans son livre _"Design Patterns: Elements of Reusable Object-Oriented Software"_ les concepts fondamentaux des **Design Patterns**.

### Qu'est-ce qu'un Design Pattern ?
Un **Design Pattern** est un schéma réutilisable pour résoudre des problèmes complexes de conception dans un environnement orienté objet.

---

### Les trois grandes catégories de Design Patterns

Les **Design Patterns** sont classés en trois catégories principales, selon leur objectif et leur mode d'application :

1. **Patterns de création**  
    Ces patterns se concentrent sur le processus de création d'objets, en fournissant des solutions pour abstraire ou cacher les détails complexes liés à l'instanciation.
    
    - **Exemples :** Singleton, Factory Method, Abstract Factory, Builder, Prototype.
2. **Patterns structurels**  
    Ces patterns aident à composer des objets ou des classes pour former des structures plus complexes tout en maintenant une flexibilité et une efficacité.
    
    - **Exemples :** Adapter, Bridge, Composite, Decorator, Facade, Flyweight, Proxy.
3. **Patterns comportementaux**  
    Ces patterns définissent comment les objets interagissent et communiquent entre eux, en mettant l'accent sur le comportement dynamique des systèmes.
    
    - **Exemples :** Observer, Strategy, Command, State, Chain of Responsibility, Mediator, Memento, Visitor.

## Exemples de Design Patterns
Voici quelques exemples courants de Design Patterns :

- **Singleton**
- **Repository**
- **Prototype**

![[Pasted image 20241230095232.png]]

### À retenir :
Les **Design Patterns** ne sont pas du code prêt à l'emploi, mais des solutions conceptuelles pour structurer efficacement votre code et résoudre des problèmes récurrents.

---

## Patterns de Construction

### Pattern Abstract Factory
Le **Pattern Abstract Factory** permet de :
- Créer des objets regroupés en familles.
- Découpler la logique de création des objets des classes concrètes, en se basant sur des interfaces communes.

> **Avantage :** Favorise l'extensibilité et la flexibilité en permettant de changer la famille d'objets sans modifier le code.

---

### Pattern Builder

Le **Pattern Builder** est un design pattern de création utilisé pour construire des objets complexes étape par étape. Contrairement à d'autres patterns comme l'**Abstract Factory**, il met l'accent sur le processus de construction plutôt que sur la logique de création des familles d'objets.

Le **Pattern Builder** permet de :
- Simplifie la création d'objets complexes en découpant leur construction en étapes claires et réutilisables.
- Permet de produire différents types et représentations d'un objet complexe avec le même code de construction.

> **Avantage :** Le **Builder** améliore la lisibilité et maintenabilité du code en rendant explicite chaque étape de construction. Il est particulièrement utile lorsque l'objet nécessite une configuration complexe.



---

### Singleton

Le **Pattern Singleton** est un design pattern de création qui vise à garantir qu'une classe n'ait qu'une seule instance tout au long de l'exécution d'un programme, tout en fournissant un point d'accès global à cette instance. Ce pattern est souvent utilisé pour les ressources partagées telles que les connexions à une base de données ou un gestionnaire de configuration.

Le **Pattern Singleton** permet de :

- Assurer qu'une classe ait uniquement une instance, même dans un environnement multi-thread.
- Fournir un moyen d'accéder globalement à cette instance unique sans créer de multiples objets.
- Gérer de manière centralisée des ressources partagées ou des états globaux.

> **Avantage :** Le **Singleton** permet de contrôler l'accès à des ressources critiques, ce qui peut améliorer l'efficacité et réduire les risques de conflits dans un programme. Il est particulièrement utile lorsqu'il faut garantir qu'un objet ou une ressource soit unique tout au long de l'application.

---

### Prototype

Le **Pattern Prototype** est un design pattern de création qui permet de créer de nouveaux objets en clonant des instances existantes au lieu d'instancier des objets directement. Ce pattern est particulièrement utile lorsque la création d'un objet est coûteuse en termes de temps ou de ressources, ou lorsque vous souhaitez éviter de dupliquer des configurations complexes.

Le **Pattern Prototype** permet de :

- Créer de nouveaux objets en copiant des prototypes existants, ce qui peut être plus performant que de créer des objets "from scratch".
- Simplifier la gestion d'objets complexes en réutilisant des configurations préexistantes.
- Permettre de modifier indépendamment les instances copiées sans affecter le prototype original.

> **Avantage :** Le **Prototype** offre une grande flexibilité et réduit la duplication de code lors de la création d'objets complexes. Il est particulièrement utile dans les systèmes où la création d'objets doit être dynamique ou basée sur des configurations spécifiques.

---

### Adapter

Le **Pattern Adapter** est un design pattern structurel qui permet de connecter des interfaces incompatibles en convertissant l'interface d'une classe existante en une autre interface attendue par les clients. Ce pattern est particulièrement utile pour intégrer des classes ou des systèmes tiers dans une application sans modifier leur code source.

Le **Pattern Adapter** permet de :

- Faciliter la compatibilité entre des classes avec des interfaces différentes.
- Réutiliser des classes existantes dans un contexte où leur interface n'est pas compatible avec les exigences actuelles.
- Favoriser l'intégration de systèmes ou de bibliothèques externes.

> **Avantage :** Le **Adapter** améliore l'interopérabilité et favorise la réutilisation de code existant sans nécessiter de modifications importantes. Cela permet de réduire le couplage entre les composants d'une application.

---

### Bridge

Le **Pattern Bridge** est un design pattern structurel qui sépare l'abstraction d'une classe de son implémentation, permettant ainsi de les développer indépendamment. Ce pattern est utile lorsque vous avez besoin de découpler des hiérarchies complexes pour améliorer la flexibilité et la maintenabilité.

Le **Pattern Bridge** permet de :

- Découpler une abstraction et son implémentation pour qu'elles puissent évoluer indépendamment.
- Réduire le couplage entre des classes abstraites et leurs implémentations.
- Favoriser l'extension et la réutilisation de code en évitant les combinaisons excessives dans les hiérarchies de classes.

> **Avantage :** Le **Bridge** améliore la modularité et réduit la complexité en permettant de modifier ou étendre les abstractions et les implémentations de manière indépendante.

---

## Annexe C#

### Composition
La composition est un mécanisme qui permet à une classe de contenir une instance d'une autre classe ou de cette même classe. Cela permet de structurer les relations entre les objets de manière hiérarchique.

#### Exemple
```csharp
public abstract class ConstructeurLiasseVehicule
{
    protected Liasse liasse; // Exemple de composition
}