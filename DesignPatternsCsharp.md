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

## Annexe C#

### Composition
La composition est un mécanisme qui permet à une classe de contenir une instance d'une autre classe ou de cette même classe. Cela permet de structurer les relations entre les objets de manière hiérarchique.

#### Exemple
```csharp
public abstract class ConstructeurLiasseVehicule
{
    protected Liasse liasse; // Exemple de composition
}