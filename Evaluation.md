Evaluation finale du cours .NET à l'IUT Lyon 1
==============================================

Critères d'évaluation
---------------------

* Solution apportée aux problèmes posés dans le fichier Readme.md + réponses aux questions (à mettre dans le fichier ci-dessous)
* La qualité des commits : granularité fine et commentaires explicites du pourquoi (et non du quoi, i.e ne pas dire quels fichiers ont été modifiés, c'est inutile, Git le dit déjà)
* La qualité du code : utiliser un nommage correct + R# donne des règles à respecter, il suffit de les corriger
* Les tests unitaires : expressivité (le nommage tout particulièrement), granularité (i.e on teste une chose à la fois), rapidité (i.e instantané), couverture de code et indépendance (un test ne dépend pas des autres)
* Le design du code : utiliser les pratiques vues en cours pour éviter de faire du code difficilement maintenable et évolutif (SOLID...)

ATTENTION: ne pas changer le nommage des projets, des classes et méthodes donnés (sauf sur les tests si vous voulez).

A LA FIN DU TP: pensez à pousser vos commits sur votre compte GitHub et envoyer votre dépôt à mon adresse mail.

Réponses aux questions posées
-----------------------------

Q1)Pour éviter d'avoir trop de ifs il faut implémenter des classes de calculs pour chaque opérations.

Q2)Le principe central est qu'un objet utilise contient des données et des comportements.

Q3)On réalise un encapsulation des données, cela permet à une classe d'avoir accès seulement aux données qui lui sont utiles.

Q4)Le calculator trainer permet de nous faire remonter des exceptions de calculs que nous avons pas traités. Cela nous permet de rajouter des exceptions tels que Format incorect ou division par 0.

Q5)Le principe appliqué est qu'une classe ne doit changer que pour une seule raison.

Q6)
 
 
 