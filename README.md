# City Chain - Command Line Interface
Command Line Interface for City Chain

```
city
```

# Commands

## Basics

Return the version of City Chain CLI (short for --version):

```
city -v
```

Return the help for available commands (short for --help):
```
city -h
```


## Vanity Address

Generate a vanity address that starts with the letters "city". The first character must be "C". The 
generated address does not respect capitalization, meaning that this command will generate address
that starts with "CiTY" or "CItY" or "citY", etc.

```sh
city --vanity "city"
```

If you need the exact casing supplied, add the option --exact.

```sh
city --vanity "city" --exact
```

The longer the prefix, the longer it will take to generate. Some characters are not supported. Start 
with a single prefix, then check how long it takes to generate with "ci" and "cit" and "city".

# Documentation

To learn more on how to extend the City Chain CLI with additional features, make sure you read 
the documentation for the CommandDotNet package: https://github.com/bilal-fazlani/CommandDotNet

