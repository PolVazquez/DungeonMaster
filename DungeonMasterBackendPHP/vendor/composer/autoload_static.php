<?php

// autoload_static.php @generated by Composer

namespace Composer\Autoload;

class ComposerStaticInit57ed9bdaa370ee7ebcf3abcbe03196d8
{
    public static $classMap = array (
        'Composer\\InstalledVersions' => __DIR__ . '/..' . '/composer/InstalledVersions.php',
    );

    public static function getInitializer(ClassLoader $loader)
    {
        return \Closure::bind(function () use ($loader) {
            $loader->classMap = ComposerStaticInit57ed9bdaa370ee7ebcf3abcbe03196d8::$classMap;

        }, null, ClassLoader::class);
    }
}