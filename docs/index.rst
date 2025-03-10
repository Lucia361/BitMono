BitMono
=======

This is the documentation of the BitMono project. BitMono is not only a tool that can be used for a two clicks to obfuscate your file, even for your own plugins and purposes - for example BitMono can be used as an Engine for your own obfuscation.

Most of the questions/problems in BitMono will be solved by just learning `AsmResolver docs <https://asmresolver.readthedocs.io>`_

Table of Contents:
------------------

.. toctree::
   :maxdepth: 1
   :caption: Protections
   :name: sec-protections

   protections/antiildasm
   protections/antide4dot
   protections/bitdotnet
   protections/bitmono
   protections/bittimedatestamp
   protections/bitmethoddotnet
   protections/antidecompiler
   protections/antidebugbreakpoints
   protections/calltocalli
   protections/dotnethook
   protections/fullrenamer
   protections/objectreturntype
   protections/stringsencryption
   protections/unmanagedstring
   protections/nonamespaces


.. toctree::
   :maxdepth: 1
   :caption: Developers
   :name: sec-developers

   developers/first-protection
   developers/obfuscation-execution-order
   developers/which-base-protection-select
   developers/protection-runtime-moniker
   developers/do-not-resolve-members
   developers/configuration


.. toctree::
   :maxdepth: 1
   :caption: Best Practices
   :name: sec-bestpractices

   bestpractices/bitmono-combo


.. toctree::
   :maxdepth: 1
   :caption: Configuration
   :name: sec-configuration

   configuration/exclude-obfuscation
   configuration/third-party-issues
   configuration/protections


.. toctree::
   :maxdepth: 1
   :caption: Frequently Asked Questions
   :name: sec-faq

   faq/costura-support
   faq/disable-path-masking
   faq/unable-to-reference-after-protect
   faq/when-and-why-use-bitmono